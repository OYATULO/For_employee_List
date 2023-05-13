// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. 
var t = false;
function f(ds) {
    ds = ds.lastElementChild;
    if (!t) {
        ds.classList.remove("d-none");
        ds.classList.add("d-inline");
    }
    else {
        ds.classList.remove("d-inline");
        ds.classList.add("d-none");
    }
    t = !t;
    console.log(ds)
}