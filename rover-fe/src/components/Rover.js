import React from 'react';

class Rover extends React.Component{

    constructor(){
        super()
    }

    render () {
        return (
            <div className="RoverDiv">
                <h2>Rover</h2>
                <p>Starting command: {this.props.inputString}</p>
                <p>Final Coordinates: ({this.props.coords.x}, {this.props.coords.y})</p>
                <p>Final Direction: {this.props.direction}</p>
            </div>
        )
    }
}

export default Rover;