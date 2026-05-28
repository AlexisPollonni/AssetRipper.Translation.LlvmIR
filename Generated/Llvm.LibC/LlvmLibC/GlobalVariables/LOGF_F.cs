using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L6LOGF_FE")]
[DemangledName("__llvm_libc_20_1_2_::LOGF_F")]
internal static partial class LOGF_F
{
	[FixedAddressValueType]
	private static Cpp_array_etzvdw __value;

	public unsafe static Cpp_array_etzvdw* Pointer => unchecked((Cpp_array_etzvdw*)Unsafe.AsPointer(ref __value));

	public static Cpp_array_etzvdw Value
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

	unsafe static LOGF_F()
	{
		Value = new Cpp_array_etzvdw
		{
			Data = InlineArrayHelper.Create<InlineArray32_Single, float>(new float[32]
			{
				0f, 0.030771658f, 0.06062462f, 0.089612156f, 0.11778303f, 0.14518201f, 0.17185026f, 0.19782574f, 0.22314355f, 0.24783616f,
				0.2719337f, 0.29546422f, 0.31845373f, 0.3409266f, 0.3629055f, 0.3844117f, 0.4054651f, 0.4260844f, 0.4462871f, 0.46608973f,
				0.48550782f, 0.504556f, 0.52324814f, 0.5415973f, 0.5596158f, 0.5773154f, 0.59470713f, 0.61180156f, 0.62860864f, 0.64513797f,
				0.6613985f, 0.6773988f
			})
		};
		_ = Pointer;
	}
}
