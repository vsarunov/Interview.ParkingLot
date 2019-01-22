# Interview.ParkingLot

Points to notice:

Assuming we have a basic car object based on plate number. As we do not have any rules for now for the car only to find the free nearest space, we can leave the car object with really basic info. Otherwise, we would populate it properly with data we can use for validation. On top of that with this rules this seems like shortest path algorithm, dijkstra algorithm. However, we are going only up and down we can use simple math.

Based on the fact that we need to know the floor and the number of free spaces (Do free spaces have numbers? or we take the first free space on the floor?) it is wise to have a dictionary with the number of the floor as the key and the number of free spaces on that floor as value. If we need to know the exact free space we could have then the dictionary/map would have a floor number as key and a list of space numbers as value.

What happens if two cars come at the same time on floor -2 and +1 and the only free space is on floor -1? Potentially this is multithreaded application.

Do we have to record the car that has been parked? Would we have to record outgoing cars in the future?

If I needed to get the car object with it details I would implement repository patern and get the object details and use the carId as the plate number.

We could have such an object as BoomBarrier Event which would contain the number of the floor at which the boom barrier has been approached and the scanned car plate number.

If we want to implement a rule engine, a proper one, we would probably use Expressions and reflection, and would have such class as "Rule"

Which would have something like:

string constrain - which would basically be the value that we should compare to/equal to 
ExpressionType expression - the expression we would use to compare e.g GreaterThan,Equals, Contains string 
valueToCompare - the value we would appy the constrain/restriction to

I have expressed some points in the comments as well.

As well you can Run Unit test to test the application. Or just run a dummy programm.

What would I do in real life application:

Multithreading - cars my come at the same time. Proper rule validation engine as mentioned above. Remove space if has been taken or add if has been freed. Specify the exact space on the floor.
