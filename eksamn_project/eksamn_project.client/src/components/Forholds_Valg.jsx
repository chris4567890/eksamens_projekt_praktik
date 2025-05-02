function Forholds_valg({ formData, setFormData }) {
    const handleChange = (e) => {
        setFormData({
            ...formData,
            RelationshipStatus: e.target.value
        });
    }
    return(
        <div>
            <form method="post">
                <p>vælg venligst din relations status</p>
                <input type="radio" name="relationship" id="single_mother" value="single_mother" onChange={handleChange} required/>
                <label htmlFor="single_mother">enlig mor</label><br />
                <input type="radio" name="relationship" id="single_father" value="single_father" onChange={handleChange} required/>
                <label htmlFor="single_father">enlig mand</label>
                <input type="radio" name="relationship" id="mother_father" value="mother_father" onChange={handleChange} required/>
                <label htmlFor="mother_father">gift kvinde og mand</label>
                
            </form>
        </div>
    )
}

export default Forholds_valg;