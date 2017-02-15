The original c++ codes can be found here : https://github.com/bachelorwhc/PlanetEditor 

Below is the example of usage of the program : 
![Screenshot of the program](https://github.com/kertaskids/PlanetEditorCS/blob/master/PlanetEditor.PNG)

Answer for the question : 
21 January 2017
 
1.  **Class** : is a general template which contains of operations (methods) and properties (variables) of particular object. Therefore object is a specific instance of a class which contains real-time values. 
2. **Constructor** : is a method to initialize the initial parameters when an object is going to be made. 
3. **Destructor** : is a method to destructs the object when the object is not needed anymore. The goal is to recover the heap space allocated, close the database connection, or release another resource.
4. **Interface** : interface is a structure that allows us to enforce certain properties on an object or class. Events, Delegates, Properties and Methods can exist; multiple interface can also be implemented on a class. 
5. **Polymorphism** : it’s simply the ability to redefine methods for derived classes. It is an ability to process objects differently depend on their data type or class. For example, a class Shape has derived classes such as Circle, Rect, Triangle. The original source code use polymorphism in : planet.h# Line 61. In the implementation on the main code, the type object_ptr can store any type of certain classes without need to know what the actual objects are. 
6. **Template** : is a generic class or other unit (function) of source code that can be used as the basis for unique units of code. For example, in vector function, there are vector<int> and vector<float>. 
7. **```Planet::Planet(const Planet & src)```** is a copy constructor. The copy constructor is a constructor which creates an object by initializing it with an object of the same class, which has been created previously. Ref: https://www.tutorialspoint.com/cplusplus/cpp_copy_constructor.htm . I don't understand the question, but I guess, why copy constructor is important? and any example? Now I get it. Based on the explanation from here : http://codepad.org/AICuercH , and the following codes : ```
Planet p1;
Creature c;
P1.add (c);
Planet p2 (p1);
Kill (c);
``` According to that codes, the c inside the planet p2 will be deleted. Because the planet p2 duplicates only the pointers, not exactly the objects. 
8. **Std :: shared_ptr** : Objects of shared_ptr types have the ability of taking ownership of a pointer and share that ownership: once they take ownership, the group of owners of a pointer become responsible for its deletion when the last one of them releases that ownership. Reference : http://www.cplusplus.com/reference/memory/shared_ptr/ . 
9. I guess whis question is about destructor or even garbage collector. I think .NET C#, is doing great about that. If we forget to dispose an object, the garbage collector will automatically collects and delete it. I think, so far, C# is the safest programming language. So if we forget to dispose, I think it will be okay.
10. **C++ vs C#** : the major different is c++ provide more limitless operation than C#. We can say that c++ interface is better comparing to many languages. Shortly I will say c++ is faster and more difficult to understand whereas c#, especially .Net, is easier to understand and safer. Also, pointer in c# is likely avoided. 
11. **Object** : is an instance of a class, containing real-time value. Abstract : is a class that contains abstract methods. Thus must be implemented on the subclasses. Object Oriented : is a term used in programming model that patterns as an object. 
