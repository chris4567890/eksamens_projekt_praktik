import { useEffect, useState } from 'react';
import './App.css';
import AmountOfChildren from './components/AmountOfChildren';
import OverensKomst from './components/Overenskomst'
import Forholds_valg from './components/Forholds_Valg';
import Overview_Of_Choices from './components/OverviewOfChoises'
import ResultPage from './components/ResultPage';
import ArbejdsStatus from './components/ArbejdsStatus';
function App() {
    const [formData, setFormData] = useState({
        Gender:'',
        multiplechildren:false,
        RelationshipStatus:'',
        Arbejdsstatus:'',
        OverEnskomst: '',
        AmountOfChildren: 0
    });

    const [page, setpage] = useState(0);
    const [result, setResult] = useState(null);

    const resultFetcher = async () => {
        try {
            console.log("I am inside the try part of resultfetcher");
            console.log("here is object data: " + JSON.stringify(formData));

            const response = await fetch('https://localhost:7296/api/barsel', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(formData)
                
            });
            
            const isJson = response.headers.get('content-type')?.includes('application/json');
            const data = isJson ? await response.json() : null;

            if (!response.ok) {
                const error = (data && data.message) || response.status;
                throw new Error(error);
            }
            console.log("fetched data: "+data)
            console.log("here is the response:", data);
            setResult(data.calculatedBarsel);

        } catch (error) {
            console.error('No data',error)
        }
    }
    useEffect(() => {
        if (page === 5) {
            console.log(formData)
            resultFetcher();
        }
    },[page])
    const nextpage = () => {
        setpage(page + 1)
    }
    const previouspage = () => {setpage(page-1) }
    return (
        <div>
            {
                page === 0 && (
                    <>
                        <Forholds_valg formData={formData} setFormData={setFormData} />
                        <button onClick={nextpage }>næste</button>
                    </>
                )
            }
            {
                page === 1 && (
                    <>
                        <OverensKomst formData={formData} setFormData={setFormData} />
                        <button onClick={previouspage }>tilbage</button>
                        <button onClick={nextpage}>næste</button>
                    </>
                )
            }
            {
                page === 2 && (
                    <>
                        <AmountOfChildren formData={formData} setFormData={setFormData} />
                        <button onClick={previouspage}>tilbage</button>
                        <button onClick={nextpage}>næste</button>
                    </>
                )
            }
            {
                page === 3 && (
                    <>
                        <ArbejdsStatus formData={formData} setFormData={setFormData} />
                        <button onClick={previouspage}>tilbage</button>
                        <button onClick={nextpage}>næste</button>
                    </>
                )
            }
            {
                page === 4 && (
                    <>
                        <Overview_Of_Choices formData={formData} />
                        <button onClick={previouspage}>tilbage</button>
                        <button onClick={nextpage}>næste</button>
                    </>
                )
            }
            {
                page === 5 && (
                    <>
                        <ResultPage result={result} formData= {formData}/>
                        <button onClick={previouspage}>tilbage</button>
                    </>
                )
            }
        </div>
    )
}
export default App;
