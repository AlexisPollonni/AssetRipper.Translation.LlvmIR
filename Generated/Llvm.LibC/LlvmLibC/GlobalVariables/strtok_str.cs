using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L10strtok_strE")]
[DemangledName("__llvm_libc_20_1_2_::strtok_str")]
internal static partial class strtok_str
{
	private partial struct __WrapperType
	{
		public unsafe void* __value;
	}

	[FixedAddressValueType]
	private static __WrapperType __value;

	public unsafe static void** Pointer => unchecked((void**)Unsafe.AsPointer(ref __value));

	public unsafe static void* Value
	{
		get
		{
			return __value.__value;
		}
		set
		{
			__value.__value = value;
		}
	}

	unsafe static strtok_str()
	{
		PointerIndices.Register(Pointer);
	}
}
