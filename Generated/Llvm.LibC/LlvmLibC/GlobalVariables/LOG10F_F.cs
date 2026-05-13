using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L8LOG10F_FE")]
[DemangledName("__llvm_libc_20_1_2_::LOG10F_F")]
internal static partial class LOG10F_F
{
	[FixedAddressValueType]
	private static cpp_array_etzvdw __value;

	public unsafe static cpp_array_etzvdw* Pointer => unchecked((cpp_array_etzvdw*)Unsafe.AsPointer(ref __value));

	public static cpp_array_etzvdw Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static LOG10F_F()
	{
		Value = new cpp_array_etzvdw
		{
			Data = InlineArrayHelper.Create<InlineArray32_Single, float>(new float[32]
			{
				0f, 0.013363961f, 0.026328938f, 0.038918067f, 0.051152524f, 0.063051745f, 0.07463362f, 0.08591463f, 0.096910015f, 0.10763388f,
				0.11809931f, 0.12831847f, 0.1383027f, 0.14806254f, 0.15760785f, 0.16694789f, 0.17609125f, 0.1850461f, 0.19382003f, 0.2024202f,
				0.21085337f, 0.2191259f, 0.22724378f, 0.23521271f, 0.24303804f, 0.25072488f, 0.258278f, 0.26570204f, 0.27300128f, 0.28017986f,
				0.2872417f, 0.2941906f
			})
		};
		PointerIndices.Register(Pointer);
	}
}
