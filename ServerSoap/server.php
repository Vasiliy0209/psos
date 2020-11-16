<?php
header("Content-type: text/xml; charset=utf-8");
header("Cache-control: no-store, no-cache");
header("Expires: ".date("r"));

ini_set("soap.wsdl_cache_enabled","0");

class myservice {
	public function my_method($args) {
		$str=$args->arg1." ".$args->arg2;
		return Array("answer"=>$str);
	}
}

$s=new SoapServer(
	"http://mysite.ru/myservice.wsdl.php"
);

$s->setClass("myservice");

$s->handle();
