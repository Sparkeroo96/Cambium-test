# Intro
Samuel Parker's Submission for the Cambium Technical test, the prototype is a .Net 5 api with a react front end.

### Time taken - 4hrs

# Pre-Reqs
1. Visual Studio 2019 with .Net 5.0
2. Yarn installed [https://yarnpkg.com/]

# Running the API
1. Open /API/API.sln in Visual Studio
2. Run the solution, it should open a swagger window at https://localhost:44307/swagger/index.html

# Running the React App
1. Navigate to rover-fe in a terminal window
2. Run "yarn" to install packages
3. Run "yarn start" to start application

# If only I had more time
## Unit test the controller
Currently there is unit tests for the Rovers and there instructions, this ensures they move correctly, however it would also be useful to unit test the controller with the post request to ensure it gives the correct object as a return.
I believe the key thing though is the rover logic as opposed to the controllers so I think i made the correct decision in implementing the rover tests.

## Finish the display tiles
Each rover is displayed sequentially and stored in the state of the react-fe, if i had more time i would finish rendering the tiles that display on the front end so that there would be the rover details in a tile showing its finishing positon.
This would be easiest to do if each tile only held one rover at the end, however it is likely that there will be more than one in each tile, so extra effort would be spent ensuring it works with duplicate rovers.

## Allow for upload of the csv file
The solution only allows for one command to be entered at a time, it could be modified to allow for the csv file to be uploaded straight to it and then read the commands straight from that so you didnt have to enter them one at a time. 
Multiple commands could be handled by spliting the input string up again by comma and then returning an array to the FE, the effort on the FE to display them would become slightly larger.

## Add a database
A data base could be used to store each rover so that "Nasa" would have them persist for all users, it could then check if there were duplicate entries and not store them or alert the user too duplicates. 
This could be implenented in the backend with Entity Framework core and a SQL server to make it easy to implement.