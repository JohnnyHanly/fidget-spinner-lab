import React from 'react';
class Spinners extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }

    showInput=() =>{
        this.props.showInput();
    }

   
    render() {
        return (
            <div className="container">

                <h1> Your Spinners </h1>
                <div className="row">

                    <div className="col-md-12">

                        <div className="row spinnerRow">
                            <p className="col-md-3 titleBox"><strong>Name </strong> </p>
                            <p className="col-md-2 titleBox"><strong>Spoke #</strong></p>
                            <p className="col-md-2 titleBox"><strong>Bearing #</strong></p>
                            <p className="col-md-3 titleBox"><strong> Special Feature</strong> </p>
                            <p className="col-md-2 titleBox"><strong> Price</strong></p>

                        </div>
                        {this.props.spinnersList.map((spinner, index) =>
                            <div className="row spinnerRow">
                                <p className="col-md-3 tableBox">{spinner.fidget_name} </p>
                                <p className="col-md-2 tableBox">{spinner.spokes}</p>
                                <p className="col-md-2 tableBox">{spinner.bearings}</p>
                                <p className="col-md-3 tableBox"> {spinner.special_feature} </p>
                                <p className="col-md-2 tableBox"> {spinner.price}</p>

                            </div>

                        )}


                        <button className="btn  btn-primary float-right" type ="button" id="addButton" onClick ={this.showInput}>Add Spinner</button>

                    </div>
                </div>
            </div>
        );
    }
}

export default Spinners;