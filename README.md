## csMaps

###**About**
This is a C# class library that uses public google maps API to give data for required location.

####**What does it offer?**
   1. Request data for a loaction by searching with it's name.
    - Get location as ** csMap ** Object
    - Get location as ** JSON ** string
   

####**Usage:**

Get Location and parse in object:
 ```C#  
  csMap location = GMap.GetLocation("New York");
```

Get Location as Json string:
 ```C#  
  string location = GMap.GetLocationJsonString("New York");
```


Started with :heart: | 2017-02-23

[Twitter](https://www.twitter.com/agonxgashi) | [Facebook](https://www.facebook.com/agonxgashi)
