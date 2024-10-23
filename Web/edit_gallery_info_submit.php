<?php
    session_start();

    require 'db.php';

    // Update db
    $stmt = $conn->prepare("UPDATE galleries SET title = ?, title_description = ?, long_description = ? WHERE id = ?");
    $stmt->bind_param("sssi", $_POST['gallerytitle'], $_POST['gallerytitledescription'], $_POST['gallerylongdescription'], $_POST['id']);
    $stmt->execute();

    $stmt->close();
    $conn->close();

    header("Location:index.php");