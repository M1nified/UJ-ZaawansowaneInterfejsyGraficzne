import React, { Component } from 'react'
import './Komp.css'

const vehicleMaker = () => {
    let makeVehicleId = 0
    const makeVehicle = (type, brand, count, capacity) => ({
        id: makeVehicleId++,
        type, brand, count, capacity
    })
    return makeVehicle
}

const VehicleRow = (props) => {
    const { id, type, brand, count, capacity } = props.vehicle
    return (
        <tr key={id}>
            <td>{id}</td>
            <td>{type}</td>
            <td>{brand}</td>
            <td>{count}</td>
            <td>{capacity}</td>
        </tr>
    )
}

class Komp extends Component {
    constructor() {
        super()
        const makeVehicle = vehicleMaker()
        this.state = {
            vehicles: [
                makeVehicle('bus', 'solaris', 10, 300),
                makeVehicle('bus', 'mercedes', 5, 500),
                makeVehicle('tram', 'pesa', 20, 600),
                makeVehicle('tram', 'bombardier', 50, 400)
            ]
        }
    }
    sortVehiclesBy(key) {
        console.log(key)
        const vehicles = this.state.vehicles.sort((a, b) => {
            if (typeof a[key] === 'number' && typeof b[key] === 'number')
                return a[key] - b[key]
            else
                return a[key].toString().localeCompare(b[key].toString())
        })
        console.table(this.state.vehicles)
        this.setState({ vehicles })
    }
    render() {
        const rows = this.state.vehicles.map((vehicle) => (
            <VehicleRow key={vehicle.id} vehicle={vehicle} />
        ))
        return (
            <div>
                <table className="vehicles">
                    <thead>
                        <tr>
                            <th onClick={this.sortVehiclesBy.bind(this, 'id')}>ID</th>
                            <th onClick={this.sortVehiclesBy.bind(this, 'type')}>TYPE</th>
                            <th onClick={this.sortVehiclesBy.bind(this, 'brand')}>BRAND</th>
                            <th onClick={this.sortVehiclesBy.bind(this, 'count')}>COUNT</th>
                            <th onClick={this.sortVehiclesBy.bind(this, 'capacity')}>CAPACITY</th>
                        </tr>
                    </thead>
                    <tbody>
                        {rows}
                    </tbody>
                </table>
            </div>
        )
    }
}

export default Komp
