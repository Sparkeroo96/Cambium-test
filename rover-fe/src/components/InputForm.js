import React from 'react';

function InputForm(props){

    return (
        <div className="inputDiv">Single Commands go here (3 3 E|MMRMMRMRRM):  

        <input id="commandInput" type="text"/> 
    
        <br/><button onClick={props.func}>Submit Command!</button>

        </div>
    );
}

export default InputForm;