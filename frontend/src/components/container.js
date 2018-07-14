import React from 'react';
import NavBar from './navbar';
import Spinners from './spinners';
import Stores from './stores';
import axios from 'axios';
import InputContainer from './inputcontainer';


class Container extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            spinnersVisible: true,
            storesVisible: false,
            inputVisible:true,
            spinners: [],
            stores: []

        }
    }

    showSpinners = () => {
        this.setState({
            spinnersVisible: true,
            storesVisible: false
        })

    }
    showStores = () => {
        this.setState({
            spinnersVisible: false,
            storesVisible: true
        })

    }
    showInput=()=>{
        this.setState({
            inputVisible:false
        })
    }

    addItem(item){

        console.log(item.name);

        axios.post("http://localhost:5000/spinners/",item)
        .then((response)=>{
            console.log(response);
        })


    }


    componentDidMount() {
        let results;
        axios.get("http://localhost:5000/spinners/")
            .then(
                (response) => {
                    console.log(response.data);
                    this.setState({
                        spinners: response.data
                    })


                }

            )

        axios.get("http://localhost:5000/stores/")
            .then(
                (response) => {
                    console.log(response.data);
                    this.setState({
                        stores: response.data
                    })


                }

            )

    }


    render() {
        return (
            <div className="container">
                <NavBar showSpinners={this.showSpinners} showStores={this.showStores} />

                <div className="row">
                    {this.state.spinnersVisible ?
                        <Spinners showInput ={this.showInput}  spinnersList = {this.state.spinners}/> : <Stores storesList= {this.state.stores} />
                    }

                </div>
                <div className="row">

                {!this.state.inputVisible ?
                <InputContainer addItem ={this.addItem}/>:null

                }
                </div>
            </div>
        )
    }
}

export default Container;