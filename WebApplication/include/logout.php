<!-- /** logout.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */ -->
<?php 
	session_start();
	session_destroy();
	die("<script>location.href = '../home.php'</script>");
?>
