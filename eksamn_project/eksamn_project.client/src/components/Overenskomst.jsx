import { useEffect,useState } from "react";
function OverensKomst({ formData, setFormData }) {
    const [haveOverEnskomst, setHaveOverEnskomst] = useState(null);
    const [OverEnskomstValueForm, setOverEnskomstValueForm] = useState(null);
    const [OverenskomstValueData, setOverenskomstValueData] = useState("");

    //code from https://stackoverflow.com/questions/69943565/how-to-populate-a-div-from-the-data-from-fetch

    
    useEffect(() => {
        if (OverenskomstValueData != "") {
            console.log("I am inside the useeffect for setformdata here is data: "+OverenskomstValueData)
            setFormData(prev => ({
                ...prev,
                OverEnskomst: OverenskomstValueData
            }));
        }
    },[OverenskomstValueData,setFormData])

    useEffect(() => {
        if (haveOverEnskomst) {
            fetch("https://localhost:7296/api/overnskomst", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify({ Gender: formData.Gender }),
            })
                .then(res => {
                    if (!res.ok) {
                        return res.text().then(text => { throw new Error(text) })
                    }
                    return res.json();
                })
                .then(data => {
                    console.log("API:", data);
                    setOverEnskomstValueForm(Array.isArray(data) ? data : []);
                })
                .catch(err => console.error("Failed to fetch overenskomster", err));
        }
    }, [haveOverEnskomst, formData.Gender]);

    //code modified from https://stackoverflow.com/questions/72301355/how-to-populate-select-options-from-an-api-call-in-react-js-on-page-load/72301547
    return (
        <div>
            <p>vælg om du har overenskomst</p>
            <input type="radio" name="haveOverEnskomst" id="overnskomst_ja" value="true" onChange={()=>setHaveOverEnskomst(true)} />
            <label htmlFor="overnskomst_ja">har overnskomst</label><br />
            {haveOverEnskomst && (
                <>
                    <label htmlFor="overenskomster">vælg en overenskomst</label>
                    <select
                        name="overenskomster" id="overnskomster" value={OverenskomstValueData} onChange={(e) => {console.log("CHOSEN:", e.target.value);setOverenskomstValueData(e.target.value);}}>
                        <option value="">vælg en overenskomst</option>
                        {Array.isArray(OverEnskomstValueForm) && OverEnskomstValueForm.map((name, index) => (
                            <option key={index} value={name.trim()}>
                                {name.trim()}
                            </option>
                        ))}
                    </select>
                </>
            )}
            <input type="radio" name="haveOverEnskomst" id="overnskomst_nej" value="false" onChange={()=>setHaveOverEnskomst(false)} />
            <label htmlFor="overnskomst_nej">har ikke overnskomst</label>
        </div>
    )
}

export default OverensKomst;
