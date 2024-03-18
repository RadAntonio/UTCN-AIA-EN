'use strict';

console.log('Welcome to Data Transmision');

document.getElementById("message").innerHTML = "Message from JavaScript";

var sum = 10;
var name = "Alexandru";
var isActive = true;

var user = {
    "id" : 1,
    "name" : "Alrexandru Cristea",
    "username": "acreistea",
    "email": "a@gmail.com",
    "address": {
        "street": "Padin",
        "number": "Ap.20",
        "city": "Cluj-Napoca",
        "geo": {
            "lat": "23.4444",
            "lng": "33.2345"
        }
    },
    "phone": "0774497017",
    "company": {
        "name": "abc",
        "domain": "AIR TRAFFIC",
        "cities": ["cluj", "viena", "paris"]
    }
}
console.log(user.company.cities[2]);
console.log(user.address.geo.lat);

var password = "1234";
console.log(password == "1234" ? "ALLOW" : "DENY");
if (password == "1234") {
    console.log("ACCEPT");
} else {
    console.log("DENY");
}