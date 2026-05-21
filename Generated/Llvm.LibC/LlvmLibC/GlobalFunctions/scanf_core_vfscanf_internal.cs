using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class scanf_core_vfscanf_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core16vfscanf_internalEP8_IO_FILEPKcRNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::vfscanf_internal(_IO_FILE*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static int Invoke([NativeType("_IO_FILE*")] void* stream, [NativeType("char const*")] void* format, [NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] internal_ArgList* args)
	{
		scanf_core_Reader scanf_core_Reader2 = default(scanf_core_Reader);
		int num = 0;
		internal_flockfile.Invoke(stream);
		llvm_lifetime_start_p0.Invoke(40L, &scanf_core_Reader2);
		llvm_memset_p0_i64.Invoke(&scanf_core_Reader2, 0, 40L, isVolatile: false);
		unchecked
		{
			scanf_core_Reader2.rb = (scanf_core_ReadBuffer*)12297829382473034410uL;
			scanf_core_Reader2.input_stream = (void*)12297829382473034410uL;
			scanf_core_Reader2.stream_getc = (void*)12297829382473034410uL;
			scanf_core_Reader2.stream_ungetc = (void*)12297829382473034410uL;
			scanf_core_Reader2.cur_chars_read = -6148914691236517206L;
			Reader_Constructor.Invoke(&scanf_core_Reader2, stream, internal_getc.__pointer, internal_ungetc.__pointer, null);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = scanf_core_scanf_main.Invoke(&scanf_core_Reader2, format, args);
			if (num == 0 && internal_ferror_unlocked.Invoke(stream) != 0)
			{
				num = -1;
			}
			internal_funlockfile.Invoke(stream);
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(40L, &scanf_core_Reader2);
			return result;
		}
	}
}
