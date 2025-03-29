// Create Connection
var connnectionUserCount = new signalR.HubConnectionBuilder().withUrl("hubs/UserCount").build();

// Connect to methods that hub invokes aka receive notifications from hub
connnectionUserCount.on("updateTotalViews", (value) => {
    let newCount = document.getElementById("totalViewsCounter");
    newCount.innerText = value.toString();
});

connnectionUserCount.on("updateTotalActiveUsers", (value) => {
    let newCount = document.getElementById("totalActiveUsersCounter");
    newCount.innerText = value.toString();
});


// Invoke hub methods aka send notification to hub
function newWindowLoadedOnClient() {
    connnectionUserCount.invoke("NewWindowLoaded").then((value) => console.log(value));
}

// Start connection
function fulfilled() {
    console.log("Connection to User Hub Successful");
    newWindowLoadedOnClient();
}
function rejected() {}

connnectionUserCount.start().then(fulfilled, rejected);