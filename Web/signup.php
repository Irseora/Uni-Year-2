<?php
	session_start();
    $loginuser = htmlspecialchars(stripslashes(trim($_POST['username'])));
	$loginpassword = htmlspecialchars(stripslashes(trim($_POST['password'])));
    $logincpassword = htmlspecialchars(stripslashes(trim($_POST['cpassword'])));
    $exists = false;

    require 'db.php';

    // Look for given username in db
    $sql = "Select * from users where user='$loginuser'";
    $result = mysqli_query($conn, $sql); 
    $num = mysqli_num_rows($result);

    // Check if username already exists in db
    if ($num == 0)
    {
        if ($loginpassword == $logincpassword && $exists == false)
        {
            // Hash password and insert new user data
            $hash = password_hash($loginpassword, PASSWORD_DEFAULT);
            $sql = "INSERT INTO `users` (`user`, `password`) VALUES ('$loginuser', '$hash')";
            $result = mysqli_query($conn, $sql);
            Header("Location:index.php");
        }
        else
        {
            echo '<script>alert("Passwords do not match!");location.replace("signup_form.php");</script>';
        }
    }

    if ($num > 0)
    {
        echo '<script>alert("Username already exists!");location.replace("signup_form.php");</script>';
    }

	$conn->close();