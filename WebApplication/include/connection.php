<!-- /** connection.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */ -->
<?php 
include ("config.php");

/** get_connection is a function that creates and returns a 
 * database connection.
 */

// connects either from Google CloudSQL or local database depending cloud or local deployment
function get_connection() {
  	if (isset($_SERVER['SERVER_SOFTWARE']) && strpos($_SERVER['SERVER_SOFTWARE'],'Google App Engine') !== false) {
	    // Connect from Cloud SQL
	    try {
	       	$db = new PDO('mysql:unix_socket=/cloudsql/curriculum-management:cms;dbname=CMS', 'root');
	    } catch(PDOException $ex){
	        die("could not connect to cloud database");
    	}
    } else {
	    // Connect from a local environment.
	    try {
	    	$db = new PDO("mysql:host=". DB_HOST .";dbname=". DB_NAME, DB_USERNAME, DB_PASSWORD);
	    } catch(PDOException $ex){
	        die("could not connect to local database");
	        $db = null;
	    }
  	}
  	return $db;
}
?>
