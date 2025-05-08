import { useEffect } from "react";
import { useState } from "react";
function OverensKomst({ formData, setFormData }) {
    const [OverEnskomst, setOverEnskomst] = useState([]);
    const handleChange = (e) => {
        setFormData({
            ...formData,
            OverEnskomst: e.target.value === "true",
        });
    }
    //code from https://stackoverflow.com/questions/69943565/how-to-populate-a-div-from-the-data-from-fetch

    
    useEffect(() => {
        if (formData.OverEnskomst) {
            fetch("https://localhost:7296/api/overnskomst", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({ Gender: formData.Gender }),
            })
                .then(res => {
                    if (!res.ok) {
                        return res.text().then(text => {throw new Error(text) })
                    }
                    return res.json();
                })
                .then(data => {
                    console.log("API:", data);
                    setOverEnskomst(Array.isArray(data) ? data : []);
                })
                .catch(err => console.error("Failed to fetch overenskomster", err));
        }
    }, [formData.OverEnskomst, formData.Gender]);
    
    //code from https://stackoverflow.com/questions/72301355/how-to-populate-select-options-from-an-api-call-in-react-js-on-page-load/72301547
    return (
        <div>
            <p>vælg om du har overenskomst</p>
            <input type="radio" name="overnsKomst" id="overnskomst_ja" value="true" onChange={handleChange} />
            <label htmlFor="overnskomst_ja">har overnskomst</label><br />
            {formData.OverEnskomst === true &&(
                <>
                    <label htmlFor="overenskomster">vælg en overenskomst</label>
                    <select name="overenskomster" id="overnskomster">
                        {Array.isArray(OverEnskomst) && OverEnskomst.map((name, index) => (
                            <option key={index} value={name}>
                                {name}
                            </option>
                        ))}
                    </select>
                </>
            )}
            <input type="radio" name="overnsKomst" id="overnskomst_nej" value="false" onChange={handleChange} />
            <label htmlFor="overnskomst_nej">har ikke overnskomst</label>
        </div>
    )
}

export default OverensKomst;