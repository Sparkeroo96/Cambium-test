import React, {Component} from 'react';
import DisplayTile from './DisplayTile';

class RoverDisplay extends React.Component{
    
    constructor(){
        super();

        this.state = {
            DisplayTile
        }
    }

    render(){
        return(
            <div className="roverDisplay">
                A rover display tile would go here, with a grid of 5 by 5 showing each rover
            </div>
        )
    }
}

export default RoverDisplay;