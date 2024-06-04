<script>
    function myFunction() {
        var x = document.getElementById("myLinks");
    if (x.style.display === "block") {
        x.style.display = "none";
        } else {
        x.style.display = "block";
        }
    }
    /* dropdown menu functions */
    document.addEventListener("DOMContentLoaded", function () {
        var dropdown = document.querySelector('.dropdown');
    var dropdownContent = document.querySelector('.dropdown-content');
    var timer;

    dropdown.addEventListener('mouseenter', function () {
        clearTimeout(timer); // Clear any existing timeout
    dropdownContent.style.display = 'block'; // Show the dropdown menu
        });

    dropdown.addEventListener('mouseleave', function () {
        timer = setTimeout(function () {
            dropdownContent.style.display = 'none'; // Hide the dropdown menu after a delay
        }, 1000); // Adjust delay (in milliseconds) as needed
        });

    dropdownContent.addEventListener('mouseenter', function () {
        clearTimeout(timer); // Clear the timeout when mouse enters the dropdown menu
        });

    dropdownContent.addEventListener('mouseleave', function () {
        dropdownContent.style.display = 'none'; // Hide the dropdown menu when mouse leaves
        });
    });
</script>