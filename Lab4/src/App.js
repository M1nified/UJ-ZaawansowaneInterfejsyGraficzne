import React, { Component } from 'react';
import './App.css';

// import Komp from './Komp'
import { EditEvent } from './Komp2.jsx'

class App extends Component {
  constructor() {
    super()
    this.state = {
      fellas: []
    }
    this.handleOnSubmit = this.handleOnSubmit.bind(this)
  }
  render() {
    const list = this.state.fellas.map(({ age, message, name }, idx) => (
      <div class="wall-elem" key={idx}>{name}, {age}: {message}
        {/* <button onClick={this.handleEditButton}>Edit</button> */}
      </div>
    ))
    return (
      <div>
        <h2>The Wall</h2>
        {list.length ? list : 'No messages'}
        <h2>Add to the Wall</h2>
        < EditEvent onSubmit={this.handleOnSubmit} />
      </div>
    );
  }
  handleOnSubmit(evt) {
    console.log(this)
    const
      member = {},
      fellas = this.state.fellas,
      keys = ["name", "age", "message"],
      defaults = {
        name: 'anon'
      }
    keys.forEach(key => {
      member[key] = evt.target.elements[key].value || defaults[key] || ''
      evt.target.elements[key].value = '';
    })
    alert(member.message || 'Empty message')
    fellas.push(member)
    this.setState({
      fellas
    })
    console.log(this.state)

  }
  handleEditButton(evt) {

  }
}

export default App;
