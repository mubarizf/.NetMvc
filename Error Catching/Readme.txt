This is an easy way to catch errors and logging error, show the error page

1.add 'Application_Error' to method your Global.asax file. 
2.add new controller for example ErrorPageController (P.S: you can also use your any existing controller)
3.add ActionResult Error to new created ErrorPageController (P.S: You can also add this method to your any existing controller)
4.It is just simple version of catching error. You can add logging, can separate error codes, e.t.c
