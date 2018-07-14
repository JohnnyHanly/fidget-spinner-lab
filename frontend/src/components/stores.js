import React from 'react';
class Stores extends React.Component {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div className="container">
                <h1> Your Stores </h1>
                <div className="row ">
                    <div className="col-md-12">
                        <div className="row spinnerRow">
                            <p className="col-md-6 titleBox"><strong>Name</strong></p>
                            <p className="col-md-6 titleBox"> <strong>Phone</strong></p>

                        </div>

                        {this.props.storesList.map((store, index) =>
                            <div className="row spinnerRow">
                                <p className="col-md-6 tableBox">{store.name}</p>
                                <p className="col-md-6 tableBox"> {store.phone}</p>

                            </div>

                        )}




                    </div>


                </div>
            </div>
        );
    }
}

export default Stores;