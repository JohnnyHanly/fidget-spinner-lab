import React from 'react';
class InputContainer extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            spokes: "",
            bearings: 0,
            features: "",
            price: 0.00
        }
    }
    render() {
        return (
            <div>
                <div className="inputForms" id="input">
                    <form>
                        <label>Name</label> <br />
                        <input type="text" value={this.name} onChange={(event) => { this.setState({name: event.target.value}) }} />

                        <label>Spoke #</label><br />
                        <input type="text" value={this.spokes} onChange={(event) => { this.setState({ spokes: event.target.value }) }} />
                    </form>
                    <form>
                        <label>Bearing #</label> <br />
                        <input type="text" value={this.bearings} onChange={(event) => { this.setState({ bearings: event.target.value }) }} />

                    </form>
                    <form>
                        <label>Special Features</label> <br />
                        <input type="text" value={this.features} onChange={(event) => { this.setState({ features: event.target.value }) }} />
                    </form>
                    <form>
                        <label>Price</label> <br />
                        <input type="text" value={this.price} onChange={(event) => { this.setState({ price: event.target.value }) }} />
                    </form>
                    <button className="btn-primary btn float-right" id="addButton" onClick={this.props.addItem.bind(this,this.state)} >Add</button>

                </div>



            </div>


        );
    }
}

export default InputContainer;