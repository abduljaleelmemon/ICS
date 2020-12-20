# Industrial control system

## Installation guide

### 1. download unity version 2019.4.9f1

### We have developed 3 different plants 

#### 1. Heat exchager plant
There are different types of heat exchanger for different purposes. We have modeled shell and tube heat exchanger which is used for heating of the water through steam pressure. The purpose of this plant is to provide desired temperature water after providing the useful information e.g. water initial temperature.

1.1.	3D Modeling

We are using unity for the 3D modeling of an industrial plant i.e., Shell and tube heat exchanger. We are using different industrial assets offered by unity. Some of the assets are cad files that cannot be imported in unity, so we have converted them into .3d files. Using these assets, we have created a model of a heat exchanger. The main models of this plant are heat exchanger, water tank, steam tank.
 
1.2.	Simulation (Coding):

Unity uses C# for scripting and has predefined components for simple animations like movement of an object, however, we can write our own components for animations like rotation, key based movements, etc. we have used scripting for simulations in heat exchanger, for example, rotation of steam valve, rotation of pin of an analogue manometer, display of outlet temperature on a digital temperature bar, working of heat exchanger (heating of water) using formulas.

 1.2.1	Valve rotation and analogue manometer simulation

 

 1.2.2	Heat exchanger with thermometer

  

 1.2.3	These two input fields take water initial and final temperature which is integrated to a formula after input is given and play button is pressed.



#### 2. Water treatement plant 
We are using unity for the 3D modeling of water treatment plant that has four primary steps involved. Coagulation in which alum metal will be added to the water tank that will be collected from the nearby river so that alum can combine with particles making heavy particles at the bottom of the tank. These particles will move to larger tank where the large particles will move to the surface and then filtration will be done. After that chlorination will be done to disinfect the water and through pipes the treated water will now be passed to houses 





2.1.	3D Modeling:
We have used unity for 3d modeling of water treatment plant. It has following components i.e. fresh water storage, coagulation tank, filtration plant, chlorination tank, distribution system, water pump, chlorine pump and a valve which are connected through pipes 










2.2.	Simulation (Coding): 
We have used scripting in water treatment plant to pump fresh water from the river which is then supplied to the rest of the system controlled through valves.

 2.2.1	Water pump pumps water from river (simulation) and stops when the level sensor in the storage tank signals it to stop.











 2.2.2	Storage tank stores water that is pump from the river and a level sensor senses the level of water in the tank and if the tank is full it signals the pump to turn off.
























 2.2.3	A valve is used to prevent backflow










 2.2.4	Coagulation tank takes water from the storage tank and has a level sensor senses the level of water in the tank and if the tank is full it signals the valve to close to prevent backflow. It also takes alum and in the sedimentation phase particles joined together in coagulation sink to the bottom of the tank and the water the moves to the filtration plant.









 2.2.5	Filtration plant filters water which most commonly uses sand gravel and charcoal to remove small particles that were not removed in the sedimentation phase. And a valve is also there to prevent backflow.













 2.2.6	Chlorination tank takes chlorine pumped from chlorine storage and disinfects the filtered water in order to kill bacteria and other microorganisms in the water. It has to valves to control water and chlorine flow.


















 2.2.7	Chlorine pump pumps chlorine from chlorine storage to the chlorination tank.









 2.2.8	The water in the chlorination tank is then distributed through pipes to nearby areas.







#### 3. Air tank control system  
Air tank control system that comprises of 3 different devices that are air storage tank, air dryer and air compressor. An air compressor converts power into potential energy stored in pressurized air i.e. compressed air which is transferred to air dryer for drying and in last air tank for storage of pressurized air. The main purpose of this plant is to control the pressure of air which is continuously required for further operation.

3.1.	3D Modeling
 	
We have used unity for 3d modeling of Air tank control system. Three main models of this plant are air storage tank, air dryer and air compressor.  Which are connected through pipes. 

3.2.	Simulation (Coding):

We have used scripting in air control system as to display the pressure in using a digital analogue and display the frequency using various formulae
 
 3.2.1	Motor Rotation (simulation) along with frequency of motor rotation. 
            
 3.2.2	Air Tank with digital manometer for air pressure.
 
 3.2.3	Set point takes input for desired air pressure in our air tank, once input is given and played button is pressed the compressor will try to adjust the air pressure inside the tank. we can restart our process by clicking on restart button, for pausing we can press on pause button. On the right-hand Air tank pressure and frequency is displayed for better visibility.

 

