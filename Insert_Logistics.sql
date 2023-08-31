insert into accounts values ('admin','admin@gmail.com','admin','e10adc3949ba59abbe56e057f20f883e',getdate(),getdate(),0);

insert into products values('P001','SamSung Galaxy',GETDATE(),GETDATE(),0);
insert into products values('P002','Iphone 13 Promax',GETDATE(),GETDATE(),0);
insert into products values('P003','Iphone 12 Promax',GETDATE(),GETDATE(),0);
insert into products values('P004','SamSung Galaxy Ultra',GETDATE(),GETDATE(),0);

insert into orders values ('O001','Quang Le','Thai Binh','0916221111','quangle@gmail.com','2023-08-28 20:10:18.683','Cau Giay, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);
insert into orders values ('O002','Dang Mien','Hai Phong','0916222222','dangmien@gmail.com','2023-08-28 20:10:18.683','Dong Da, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);
insert into orders values ('O003','Thuy Linh','Ninh Binh','09162233333','linhthuy@gmail.com','2023-08-28 20:10:18.683','Hoang Mai, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);
insert into orders values ('O004','Ngoc Huyen','Nam Dinh','0916224444','ngochuyen@gmail.com','2023-08-28 20:10:18.683','Nam Tu Liem, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);
insert into orders values ('O005','Luc Tran','Ninh Binh','0916225555','luctran@gmail.com','2023-08-28 20:10:18.683','Ha Dong, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);
insert into orders values ('O006','Tuan Anh','Nghe An','0916226666','tuananh@gmail.com','2023-08-28 20:10:18.683','Nam Tu Liem, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);
insert into orders values ('O007','Thu Nguyen','Quang Ninh','0916221111','thunguyen@gmail.com','2023-08-28 20:10:18.683','Cau Giay, Ha Noi','2023-08-30 20:10:18.683','2023-08-26 20:10:18.683','2023-08-26 20:10:18.683',0,0);

insert into order_details values ('P001','O001',2000000,1);
insert into order_details values ('P002','O002',3500000,2);
insert into order_details values ('P002','O003',4500000,2);
insert into order_details values ('P004','O004',5000000,3);
insert into order_details values ('P001','O005',5000000,2);
insert into order_details values ('P004','O006',3000000,2);
insert into order_details values ('P003','O007',2000000,3);
insert into order_details values ('P002','O001',6000000,2);
insert into order_details values ('P002','O002',1500000,1);
insert into order_details values ('P003','O004',2500000,2);

