import React from "react";
import './LoginForm.css';

const LoginForm = (props) => {
	const userRef = React.createRef();
	const passRef = React.createRef();

	const handleSubmit = (event) => {
		event.preventDefault();

		props.onSubmit({
			login: userRef.current.value,
			password: passRef.current.value,
		});

		userRef.current.value = "";
		passRef.current.value = "";
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input ref={userRef} type="text" id="name" />
			<label htmlFor="password">Password</label>
			<input ref={passRef} type="password" id="password" />
			<button type="submit" onClick={handleSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;