<?php
    session_start();

    require 'db.php';

    // Move new profile picture and give a unique name to it
    $new_filename = time()."_".$_FILES["new_pfp"]["name"];
    move_uploaded_file($_FILES["new_pfp"]["tmp_name"], "images/users/".$new_filename);

    // Delete old profile picture
    unlink("images/users/".$_SESSION['uimage']);

    // Update db
    $stmt = $conn->prepare("UPDATE users SET user = ?, user_image = ?, user_short_description = ? WHERE id = ?");
    $stmt->bind_param("sssi", $_POST['new_username'], $new_filename, $_POST['new_description'], $_POST['user_id']);
    $stmt->execute();

    $stmt->close();
	$conn->close();

    header("Location:logout.php");