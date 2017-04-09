## csMaps

### **About**
This is a C# class library that uses public google maps API to give data for required location.

### **What does it offer?**
   1. Request data for a loaction by searching with it's name.
    - Get location as an Object of type `csMap`
    - Get location as `JSON` string
   
### **How do I get it?**
   - Feel free to clone or fork this project on github
   - If you're runing yout appliaction on .NET Core, you can install nuget package on visual studio

> ## ```PM> Install-Package CSMaps```


### **Usage:**

Get Location and parse in object:
 ```C#  
  csMap location = GMap.GetLocation("New York");
```

Get Location as Json string:
 ```C#  
  string location = GMap.GetLocationJsonString("New York");
```

### **Returned status codes:**


   - `OK` indicates the response contains a valid result.
   - `NOT_FOUND` indicates that the origin and/or destination of this pairing could not be geocoded.
   - `ZERO_RESULTS` indicates no route could be found between the origin and destination.


### **Some of most important features:**

>##### **Get Latitude and Longitude... Or both of them as string**

 ```C#  
  csMap location = GMap.GetLocation("New York"); //Populates object with data

 string status = location.Status; //Returned request status. 
 List<csMaps.Result> results = location.Results; //A list with all founded results
 
 string coordinates = location.Results.ElementAt(0).Coordinates; //Ex: [ 40.7127837 -74.0059413 ]
 string lat = location.Results.ElementAt(0).Geometry.Location.Latitude; // Ex: [ 40.7127837 ]
 string lng = location.Results.ElementAt(0).Geometry.Location.Longitude; // Ex: [ -74.0059413 ]
```
>##### **Find distance between two points**


```C#
csMap location1 = GMap.GetLocation("New York");
csMap location2 = GMap.GetLocation("California");

LatLng l1 = location1.Results.ElementAt(0).Geometry.Location;
LatLng l2 = location2.Results.ElementAt(0).Geometry.Location;

double? distance = GMap.DistanceBetweenPlacesInKilometers(l1, l2); // [ 3923.11 ]
```


__________________________________


Started with :heart: by @agonxgashi

[Twitter](https://www.twitter.com/agonxgashi) | [Facebook](https://www.facebook.com/agonxgashi)

> [Telegram : agonxgashi](https://telegram.me/agonxgashi)
