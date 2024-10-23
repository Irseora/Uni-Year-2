<?php
	session_start();

	$gallery_id=$_GET['id'];
	require_once 'vendor/autoload.php';
	require 'db.php';

	if (!isset($_SESSION['uname'])){
        $_SESSION['uname'] = '';
		$_SESSION['uid'] = 0;
		$_SESSION['uimage'] = 'user_image.jpg';
		$_SESSION['udescription'] = 'There is no user logged in.';
    }

	$loader = new \Twig\Loader\FilesystemLoader('templates');
	$twig = new \Twig\Environment($loader);
	$pagetitle ='show gallery';

	// Select carousel images
	$sql = "SELECT * FROM carousel";
	$result_c = $conn->query($sql);

	// Select gallery info
	$sql= "SELECT * FROM galleries WHERE id=$gallery_id";
	$result_g = $conn->query($sql);

	// Select gallery pictures
	$sql = "SELECT * FROM pictures WHERE id_gallery = $gallery_id";
	$result_p = $conn->query($sql);

	echo $twig->render('show_gallery.tpl.html', [
		'titlu' => $sitetitle.' | '.$pagetitle,
		'result_c' => $result_c ,
		'result_g' => $result_g,
		'result_p' => $result_p,
		'user_name'=>$_SESSION['uname'],
		'user_id' =>$_SESSION['uid'],
		'user_image'=>$_SESSION['uimage'],
		'user_description'=>$_SESSION['udescription']
	]);

	$conn->close();