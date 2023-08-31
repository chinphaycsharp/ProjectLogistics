use Logistics;

select o.id, sum(od.total_price) total_price, sum(od.quantity) quantity from order_details od
join products p on od.product_id = p.id
join orders o on o.id = od.order_id
group by o.id;

create view v_top_order_max_prices
as
select o.id, o.customer_email, o.customer_name, o.customer_address,o.customer_phone, odc.total_price,odc.quantity,o.status from orders o
join (select o.id, sum(od.total_price) total_price, sum(od.quantity) quantity from order_details od
join products p on od.product_id = p.id
join orders o on o.id = od.order_id
group by o.id) odc on o.id = odc.id;


create view v_orderdetails
as
select o.id, o.customer_email, o.customer_name, o.customer_address,o.customer_phone, odg.total_price,odg.quantity, o.status from orders o 
join (select od.order_id, sum(od.total_price) total_price, sum(od.quantity) quantity from order_details od
group by od.order_id) as odg on o.id = odg.order_id;
