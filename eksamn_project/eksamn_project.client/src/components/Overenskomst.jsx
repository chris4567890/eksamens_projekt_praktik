function OverensKomst({formData,setFormData }) {
    const handleChange = (e) => {
        setFormData({
            ...formData,
            OverEnskomst: e.target.value ==="true"
        });
    }
    return (
        <div>
            <p>vælg om du har overenskomst</p>
            <input type="radio" name="overnsKomst" id="overnskomst_ja" value="true" onChange={handleChange} />
            <label htmlFor="overnskomst_ja">har overnskomst</label><br />
            <input type="radio" name="overnsKomst" id="overnskomst_nej" value="false" onChange={handleChange} />
            <label htmlFor="overnskomst_nej">har ikke overnskomst</label>
        </div>
    )
}

export default OverensKomst;