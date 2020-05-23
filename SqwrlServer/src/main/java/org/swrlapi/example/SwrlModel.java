package org.swrlapi.example;

public class SwrlModel {
	private String path;
	private String query;

	public String getPath() {
		return path;	
	}
		
	public void setPath(String path) {
		this.path = path;	
	}
	
	public String getQuery() {
		return query;	
	}
		
	public void setQuery(String query) {
		this.query = query;	
	}
	

@Override
public String toString() {
	return "Result [path=" + path + ", query=" + query + "]";
}
	
}
