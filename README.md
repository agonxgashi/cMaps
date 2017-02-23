## csMaps

###**About**
This is a C# class library that uses public google maps API to give data for required location.

###**What does it offer?**
   1. Request data for a loaction by searching with it's name.
    - Get location as an Object of type `csMap`
    - Get location as `JSON` string
   

###**Usage:**

Get Location and parse in object:
 ```C#  
  csMap location = GMap.GetLocation("New York");
```

Get Location as Json string:
 ```C#  
  string location = GMap.GetLocationJsonString("New York");
```

###**Returned status codes:**


   - `OK` indicates the response contains a valid result.
   - `NOT_FOUND` indicates that the origin and/or destination of this pairing could not be geocoded.
   - `ZERO_RESULTS` indicates no route could be found between the origin and destination.


###**Some of most important features:**

>#####**Get Latitude and Longitude... Or both of them as string**

 ```C#  
  csMap location = GMap.GetLocation("New York"); //Populates object with data
  
  string status = location.status; //Returned request status. 
  
  List<Result> results = location.results; //A list with all founded results
  string coordinates = location.results.ElementAt(i).Coordinates; //Ex: [ 42.6629138 21.1655028 ]
  string lat = location.Results.ElementAt(i).Geometry.Location.Latitude; // Ex: [ 42.6629138 ]
  string lng = location.Results.ElementAt(i).Geometry.Location.Longitude; // Ex: [ 21.1655028 ]
```
>#####**Find distance between two points**


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
