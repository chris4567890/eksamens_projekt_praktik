function ArbejdsStatus({formData,setFormData }) {
    const handleChange = (e) => {
        setFormData({
            ...formData,
            Arbejdsstatus: e.target.value
        });
    }
    return (
        <div>
            <p>Vælg om du er offentligt ansat eller privat ansat</p>
            <input type="radio" name="arbejdsstatus" id="offentlig" value="offentlig" onChange={handleChange} required/>
            <label htmlFor="offentlig">offentlig ansat</label><br />
            <input type="radio" name="arbejdsstatus" id="privat" value="privat" onChange={handleChange} required/>
            <label htmlFor="privat">privat ansat</label>
        </div>
    )
}

export default ArbejdsStatus;