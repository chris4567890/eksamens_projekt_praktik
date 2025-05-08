import { useState } from "react";
function Forholds_valg({ formData, setFormData }) {
    const [isSingle, setIsSingle] = useState(null)        ;
    const handleChange = (e) => {
        setFormData({
            ...formData,
            RelationshipStatus: e.target.value,
            Gender: e.target.value === "single_mother" || e.target.value === "single_father" ? "female" : "male"
        });
    }
    const handleMainChange = (e) => {
        const value = e.target.value === "true"; 
        setIsSingle(value);
    }

    

    return(
        <div>
            <form method="post">

                <p>vælg om du er single eller i et forhold</p>
                <input type="radio" name="relationship" id="single" value="true" onChange={handleMainChange } />
                <label htmlFor="single">enlig</label>
                <input type="radio" name="relationship" id="forhold" value="false" onChange={handleMainChange } />
                <label htmlFor="single">forhold</label>

                {isSingle === true && (
                    <>
                        <input type="radio" name="relationship_choice" id="single_mother" value="single_mother" onChange={handleChange} required/>
                        <label htmlFor="single_mother">enlig mor</label><br />
                        <input type="radio" name="relationship_choice" id="single_father" value="single_father" onChange={handleChange} required/>
                        <label htmlFor="single_father">enlig mand</label>
                    </>
                )}

                {isSingle ===false &&(<>
                    <input type="radio" name="relationship" id="mother_father" value="mother_father" onChange={handleChange} required/>
                    <label htmlFor="mother_father">gift kvinde og mand</label>
                    <input type="radio" name="relationship" id="mother_mother" value="mother_mother" onChange={handleChange} required />
                    <label htmlFor="mother_mother">mor og mor</label>
                    <input type="radio" name="relationship" id="father_father" value="father_father" onChange={handleChange} required />
                    <label htmlFor="father_father">far og far</label>
                </>)}
            </form>
        </div>
    )
}

export default Forholds_valg;