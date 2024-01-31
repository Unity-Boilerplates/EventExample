# Event system example, and more

Lot of stuff to play with.


This project uses:
* Events to communicate between objects (The bullet collide with player, and send an event to the player to take damage, with the parameter)
* Variables in a more wicked  style, using scriptable objects.

## References
* For fancy variables with ScriptableObjects, and events in general: [https://www.youtube.com/watch?v=raQ3iHhE_Kk](https://www.youtube.com/watch?v=raQ3iHhE_Kk)
This video has a complete example for the variables, variables references and Events in General. From there, I created some examples to support Events for specific types (one Event and Event Listener definition per type. As I found over there on the Internet, even the Blog of the Author, says that's better this way. For example, the author added an Editor Script to Raise events on the Channels from the editor it self, I created another for Int events.


* For Events supporting EVERY type of data: https://www.youtube.com/watch?v=7_dyDmF0Ktw
A more complete example, but loses the ability to use the editor to invoke.

Feel free to use.
