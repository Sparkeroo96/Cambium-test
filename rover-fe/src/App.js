import React, {Component} from 'react';
import InputForm from './components/InputForm';
import RoverDisplay from './components/RoverDisplay';
import Rover from './components/Rover';
import './App.css';

const RequestUrl = "https://localhost:44307/api/Rover";
class App extends Component {

	
	constructor(){
		super();

		this.state ={
			rovers: []
		}

		this.submitRover = this.submitRover.bind(this);
	}

	render() {
		console.log("render state");
		console.log(this.state);

		let roverComponents = this.state.rovers.map((item, index) => {
			return (
				<Rover key={`rover-${index}`} inputString={item.inputString} coords={item.coords} direction={item.direction}/>
			)
		})

		return (
			<div className="App" >
				<h1>Mars Rover</h1>
				<RoverDisplay/>	
				<InputForm func={this.submitRover}/>

				{roverComponents}
			</div>
		);
	}

	submitRover(rover){
		console.log("state")
		console.log(this.state)
		let inputCommand = document.querySelector("#commandInput").value;//'1 2 N | LMLMLMLMM';
		console.log(inputCommand)

		fetch(RequestUrl, {
			mode:"cors",
			method: 'POST',
			headers: { 'Content-Type': 'application/json' },
			body: JSON.stringify({ inputString: inputCommand })
			})
			.then(res => res.json())
			.then(result => {
				let updatedRovers;
				let newRover = {
					inputString: inputCommand,
					coords : {
						x: result.coords.item1,
						y: result.coords.item2
					},
					direction: result.direction
				}

				this.setState(prevState => {
					updatedRovers = prevState.rovers.concat(newRover);
					return {
						rovers: updatedRovers
					}
				});

			}, 
			(error) => {
				console.log("Error with request");
			})
		

		
	}
}

export default App;
