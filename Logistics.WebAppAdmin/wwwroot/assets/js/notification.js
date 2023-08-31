function CreateNotification(message, type) {
    console.log(type);
    const container = document.getElementById("container");
    const notif = document.createElement("div");
    if (type == "error") {
        notif.classList.add("alert", "alert-danger");
    }
    if (type == "success") {
        notif.classList.add("alert", "alert-success");
    }

    notif.innerText = message;

    container.appendChild(notif);

    setTimeout(() => {
        notif.remove();
    }, 3000);
}