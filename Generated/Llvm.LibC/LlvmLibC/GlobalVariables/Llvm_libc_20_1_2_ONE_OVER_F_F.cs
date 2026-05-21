using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L12ONE_OVER_F_FE")]
[DemangledName("__llvm_libc_20_1_2_::ONE_OVER_F_F")]
internal static partial class Llvm_libc_20_1_2_ONE_OVER_F_F
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_cpp_array_etzvdw __value;

	public unsafe static Llvm_libc_20_1_2_cpp_array_etzvdw* Pointer => unchecked((Llvm_libc_20_1_2_cpp_array_etzvdw*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_cpp_array_etzvdw Value
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

	unsafe static Llvm_libc_20_1_2_ONE_OVER_F_F()
	{
		Value = new Llvm_libc_20_1_2_cpp_array_etzvdw
		{
			Data = InlineArrayHelper.Create<InlineArray32_Single, float>(new float[32]
			{
				1f,
				32f / 33f,
				0.9411765f,
				32f / 35f,
				8f / 9f,
				0.8648649f,
				0.84210527f,
				32f / 39f,
				0.8f,
				0.7804878f,
				16f / 21f,
				0.74418604f,
				0.72727275f,
				32f / 45f,
				0.6956522f,
				0.68085104f,
				2f / 3f,
				0.6530612f,
				0.64f,
				32f / 51f,
				0.61538464f,
				0.6037736f,
				16f / 27f,
				32f / 55f,
				0.5714286f,
				32f / 57f,
				0.55172414f,
				0.5423729f,
				8f / 15f,
				0.52459013f,
				0.516129f,
				32f / 63f
			})
		};
		PointerIndices.Register(Pointer);
	}
}
