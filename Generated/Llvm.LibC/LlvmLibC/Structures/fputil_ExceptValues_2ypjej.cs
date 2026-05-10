using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 160)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.1211")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_2ypjej
{
	[FieldOffset(0)]
	public InlineArray16_fputil_ExceptValues_Float16_21_Mapping values;
}
