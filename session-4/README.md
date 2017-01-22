# Unity and Cake

# Session 3: UI and polish

## What we learned this week

* We learned about Scenes in Unity, and how to move between them.

* We learned how to add a little graphical flair to our games, using particles and image effects.

* We learned how to write code that lets our components talk to other components.

## This week’s homework

* Read through these notes and keep them handy as you go through the following steps.

* Work on your projects!

## The Unity Editor

### UI

## Writing code

This week we learned how to use access modifiers in our scripts and how our components can communicate with other components.

### Access modifiers

### Other components as variables

### Accessing variables and functions of other components

So, here’s some really cool stuff you can do now - if you have a variable that is a reference to another component, you can access variables and functions of that other component by using the dot operator.

You write the name of the variable that has the reference to the other component, then a dot, and then you can access the public variable or function you want to use from that component. Like this:

<pre>
void OnTriggerEnter (Collider thingCollidedWith)
{
    Debug.Log(“I collided with ” + thingCollidedWith.name);
}
</pre>

## Resources

