<?php
	session_start();

    $old_password = htmlspecialchars(stripslashes(trim($_POST['old_password'])));
    $new_password = htmlspecialchars(stripslashes(trim($_POST['new_password'])));
    $new_cpassword = htmlspecialchars(stripslashes(trim($_POST['new_cpassword'])));

    require 'db.php';

    $stmt = $conn->prepare("SELECT * FROM users WHERE user = ?");
    $stmt->bind_param("s", $_SESSION['uname']);
    $stmt->execute();
	$row = $stmt->get_result()->fetch_assoc();

    if ($row && password_verify($old_password, $row['password']) && $new_password == $new_cpassword)
    {
        $hash = password_hash($new_password, PASSWORD_DEFAULT);
        $stmt = $conn->prepare("UPDATE users SET `password` = ? WHERE id = ?");
        $stmt->bind_param("si", $hash, $_POST['user_id']);
        $stmt->execute();
        Header('Location:logout.php');
    }
    else if ($new_password != $new_cpassword)
    {
        echo '<script>alert("Passwords do not match!");location.replace("change_password_form.php");</script>';
    }
    else
    {
        echo '<script>alert("Wrong password!");location.replace("change_password_form.php");</script>';
    }

	$stmt->close();
	$conn->close();