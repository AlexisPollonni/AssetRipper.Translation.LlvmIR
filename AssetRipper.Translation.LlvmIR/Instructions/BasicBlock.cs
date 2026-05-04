using System.Collections;
using System.Diagnostics;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.PE.DotNet.Cil;

namespace AssetRipper.Translation.LlvmIR.Instructions;

public sealed class BasicBlock : IReadOnlyList<Instruction>, IList<Instruction>
{
	public Instruction this[int index]
	{
		get => Instructions[index];
		set => Instructions[index] = value;
	}

	public CilInstructionLabel Label { get; } = new();
	public List<Instruction> Instructions { get; } = new();

	public int Count => Instructions.Count;

	bool ICollection<Instruction>.IsReadOnly => ((ICollection<Instruction>)Instructions).IsReadOnly;

	public void Add(Instruction item) => Instructions.Add(item);

	public void AddInstructions(CilInstructionCollection instructions)
	{
		int labelIndex = instructions.Count;

		int stackHeight = 0;
		foreach (Instruction instruction in Instructions)
		{
			if (stackHeight < instruction.PopCount)
				throw new InvalidOperationException(
					$"Stack underflow when adding instructions (height={stackHeight}, popCount={instruction.PopCount}, instruction={instruction.GetType().Name})"
				);
			instruction.AddInstructions(instructions);
			stackHeight += instruction.StackEffect;
		}
		if (stackHeight != 0)
			throw new InvalidOperationException(
				$"Stack should be empty after adding instructions (height={stackHeight}, instructions=[{string.Join(", ", Instructions.Select(i => $"{i.GetType().Name}(pop={i.PopCount},push={i.PushCount})"))}])"
			);

		if (instructions.Count > labelIndex)
		{
			Label.Instruction = instructions[labelIndex];
		}
		else
		{
			Label.Instruction = instructions.Add(CilOpCodes.Nop);
		}
	}

	public void Clear() => Instructions.Clear();

	public bool Contains(Instruction item)
	{
		return Instructions.Contains(item);
	}

	public void CopyTo(Instruction[] array, int arrayIndex)
	{
		Instructions.CopyTo(array, arrayIndex);
	}

	public IEnumerator<Instruction> GetEnumerator()
	{
		return Instructions.GetEnumerator();
	}

	public int IndexOf(Instruction item)
	{
		return Instructions.IndexOf(item);
	}

	public void Insert(int index, Instruction item)
	{
		Instructions.Insert(index, item);
	}

	public bool Remove(Instruction item)
	{
		return Instructions.Remove(item);
	}

	public void RemoveAt(int index)
	{
		Instructions.RemoveAt(index);
	}

	public void RemoveRange(int index, int count)
	{
		Instructions.RemoveRange(index, count);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)Instructions).GetEnumerator();
	}
}
