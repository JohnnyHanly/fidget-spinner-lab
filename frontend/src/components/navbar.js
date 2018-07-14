import React from 'react';
class NavBar extends React.Component {
    constructor(props) {
        super(props);
        this.stat = {}
    }

    showSpinners = () => {
        this.props.showSpinners();
    }
    showStores = () => {
        this.props.showStores();
    }
    render() {
        return (
            <div className="container">
                <div id="myNav">
                    <nav className="navbar float-right">
                        <form className="form-inline">
                            <button className="btn btn-outline-primary nav-button" onClick={this.showSpinners} type="button">Spinners</button>
                            <button className="btn btn-outline-primary nav-button" onClick={this.showStores} type="button">Stores</button>
                        </form>
                    </nav>
                </div>
            </div>

        )
    }

}
export default NavBar;


