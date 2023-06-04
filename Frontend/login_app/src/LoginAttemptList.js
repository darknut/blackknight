import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = (props) => {
    const [filter, setFilter] = React.useState("");

    const filteredList = React.useMemo(() =>
        props.attempts.filter(
            attempt => attempt.login.indexOf(filter) >= 0),
        [props.attempts, filter]);

    return (<div className="Attempt-List-Main">
        <p>Recent activity</p>
        <input type="input" placeholder="Filter..."
            onChange={(value) => setFilter(value.target.value)} />
        <ul className="Attempt-List">
            {filteredList.map(
                (attempt) => <LoginAttempt>{attempt.login}</LoginAttempt>
            )}
        </ul>
    </div>);
};

export default LoginAttemptList;