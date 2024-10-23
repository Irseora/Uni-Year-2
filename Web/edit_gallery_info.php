<?php
    session_start();

    require_once 'vendor/autoload.php';
    require 'db.php';

    $loader = new \Twig\Loader\FilesystemLoader('templates');
    $twig = new \Twig\Environment($loader);
    $pagetitle = 'Edit gallery info';

    // Select carousel images
    $sql = "SELECT * FROM carousel";
    $result_c = $conn->query($sql);

    // Select gallery info
    $gallery_id=$_GET['id'];
    $sql = "SELECT * FROM galleries WHERE id=$gallery_id";
    $result_g = $conn->query($sql);
    $row = $result_g->fetch_assoc();

    echo $twig->render('edit_gallery_info_form.tpl.html', [
        'pagetitle' => $pagetitle,
        'result_c' => $result_c,

        'result_g' => $result_g,
        'g_id' => $gallery_id,
        'old_title' => $row['title'],
        'old_title_description' => $row['title_description'],
        'old_long_description' => $row['long_description'],

        'user_name'=>$_SESSION['uname'],
        'user_id' =>$_SESSION['uid'],
        'user_image'=>$_SESSION['uimage'],
        'user_description'=>$_SESSION['udescription']
    ]);

    