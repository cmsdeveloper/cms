<!-- /** header.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */ -->

<html>
  <head>
    <title>AUI Curriculum Management</title>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="css/main.css">
    <LINK REL="SHORTCUT ICON" HREF="Icon/FaviconTransparent_32.ico">
  </head>
  <div id="header">
    <div id="header-content" align="center">
      <h2>AUI Curriculum Management System</h2>
    </div>
  </div>
  <div id="navigation">
		<div id="navigation-content">
			<ul>
				<li><a class="nav-item" href="home.php">Home</a></li>
				<li>
					<?php
						if(isset($_SESSION["user_id"])){
							echo "<a class=\"nav-item\"href=\"include/logout.php\">Logout</a>";
						} else {
							echo "<a class=\"nav-item\"href=\"login.php\">Login</a>";
						}
					?>
				</li>
			</ul>
		</div>
	</div>
