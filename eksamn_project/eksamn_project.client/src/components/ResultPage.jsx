import { useState } from "react";
function ShowResult({ result, formData }) {
    const [amountOfWeeks, setAmountOfWeeks] = useState(result);
    console.log("here is result: "+result);
    function CalculateAmountOfWeeks() {
        if (amountOfWeeks > result) {
            setAmountOfWeeks(prev => prev - 1);
        }
        
    }
    const amount = [];
    for (let i = 1; i <= formData.AmountOfChildren; i++) {
        amount.push(
            <div key={i}>
                <p>child {i}</p>  <input type="number" name="amount_of_barsel" min="0" max={amountOfWeeks} defaultValue={0} onChange={CalculateAmountOfWeeks } />
            <br /></div>);
    }
    return (
        <div>
            <p>du har {result} ugers barsel til {formData.multiplechildren ? "rådighed for dine børn" : "rådighed for dit barn" }</p>

            {formData.multiplechildren ?
                <div> <p>her kan du fordele antallet af uger blandt dine børn</p> {amount}</div>
                : <div></div>  }
        </div>
    )
}

export default ShowResult;