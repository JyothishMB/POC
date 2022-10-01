/* eslint-disable */
import React from 'react';
import './ExpenseItem.css';

function ExpenseItem() {
    return (
        <div className="expense-item">
            <div>Date</div>
            <div className="expense-item__description">
                <h2>Car Insurance</h2>
                <h2 className="expense-item__price">$296.85</h2>
            </div>
        </div>
    );
}

export default ExpenseItem;