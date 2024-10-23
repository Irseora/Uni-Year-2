<?php
    session_start();

    require_once 'vendor/autoload.php';
    require 'db.php';

    if (!isset($_SESSION['uname'])){
        $_SESSION['uname']='';
		$_SESSION['uid']=0;
		$_SESSION['uimage']='user_image.jpg';
		$_SESSION['udescription']='There is no user logged in.';
    }

    $loader = new \Twig\Loader\FilesystemLoader('templates');
    $twig = new \Twig\Environment($loader);
    $pagetitle = 'All Galleries';
    $sql = "SELECT * FROM carousel";
	$result_c = $conn->query($sql);
    $sql = "SELECT * FROM galleries";
	$result_g = $conn->query($sql);
    $username = 'ADMIN';

    echo $twig->render('index.tpl.html', [
        'titlu' => $sitetitle.' | '.$pagetitle,'result_c' => $result_c,
        'result_g' => $result_g,
        
        'user_name'=>$_SESSION['uname'],
        'user_id' =>$_SESSION['uid'],
        'user_image'=>$_SESSION['uimage'],
        'user_description'=>$_SESSION['udescription']
    ]);

    $conn->close();
