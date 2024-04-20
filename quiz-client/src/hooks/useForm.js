import { useState } from 'react';

export default function useForm(getFreshModelObject) {
    
    // These state objects will save the values from user inputs
    const[values, setValues] = useState(getFreshModelObject());
    // Initialized errors state object to catch error
    const[errors, setErrors] = useState([]);

    // reusable function to avoid re-writing in every forms
    const handleInputChange = e => {
        const { name, value } = e.target
        setValues({
            ...values,
            [name]: value
        })
    }

    return {
        values,
        setValues,
        errors,
        setErrors,
        handleInputChange
    };
}

