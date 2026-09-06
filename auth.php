<?php
session_start();
function require_role($role){if(!isset($_SESSION['user_id'])||$_SESSION['role']!==$role){header('Location: ../index.php');exit;}}
?>
