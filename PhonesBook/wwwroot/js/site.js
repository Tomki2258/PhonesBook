﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("ContactForm").onsubmit = function () {
    return validateForm();
};
function validateForm() {
    console.log("is java script working ?")
}