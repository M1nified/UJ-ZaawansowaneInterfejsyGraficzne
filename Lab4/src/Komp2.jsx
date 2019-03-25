import React from 'react'

import './Komp2.css'

const EditEvent = ({ onSubmit }) => (
    <form onSubmit={(evt) => { evt.preventDefault(); onSubmit && onSubmit(evt); }}>
        <div className="edit-Event">
            <div className="edit-Event__input">
                <label htmlFor="name">Name: </label>
                <input type="text" id="name" name="name" />
            </div>
            <div className="edit-Event__input">
                <label htmlFor="age">Age: </label>
                <input type="number" id="age" name="age" min="16" />
            </div>
            <div className="edit-Event__input">
                <label htmlFor="message">Message: </label>
                <textarea type="text" id="message" name="message" ></textarea>
            </div>
            <div className="edit-Event__input">
                <input type="submit" id="submit" />
            </div>
        </div>
    </form>
)

export { EditEvent }

