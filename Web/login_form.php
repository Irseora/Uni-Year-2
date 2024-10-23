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
	$pagetitle = 'Login';
	$sql = "SELECT * FROM carousel";
	$result_c = $conn->query($sql);

	echo $twig->render('login_form_base.tpl.html', [
		'titlu' => $sitetitle.' | '.$pagetitle, 'result_c' => $result_c ,
		'user_name'=>$_SESSION['uname'],
		'user_id' =>$_SESSION['uid'],
		'user_image'=>$_SESSION['uimage'],
		'user_description'=>$_SESSION['udescription']
	]);
